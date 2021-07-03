using System;
using System.Collections.Generic;
using System.Text;

namespace SmartPhoneApplication
{
    public class SmartPhone : ICamera, IGps, IPhone
    {
        ICamera _camera;
        IGps _gps;
        IPhone _phone;

        public void SetCamera(ICamera camera)
        {
            this._camera = camera;
        }
        public void SetGps(IGps gps)
        {
            this._gps = gps;
        }
        public void SetPhone(IPhone phone)
        {
            this._phone = phone;
        }
        public void TakePicture()
        {
            this._camera.TakePicture();
        }
        public void Hangup() { this._phone.Hangup(); }
        public void Release() { this._phone.Release(); }
        public void Navigate() { this._gps.Navigate(); }
    }
}
