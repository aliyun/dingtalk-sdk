<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vapp_market_1_0\Models;

use AlibabaCloud\Tea\Model;

class EnsureUserLicenseAccessResponseBody extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example true
     *
     * @var bool
     */
    public $allowed;

    /**
     * @description This parameter is required.
     *
     * @example LICENSE_ASSIGNED_NOW
     *
     * @var string
     */
    public $decisionCode;

    /**
     * @description This parameter is required.
     *
     * @example true
     *
     * @var bool
     */
    public $licenseAssigned;
    protected $_name = [
        'allowed' => 'allowed',
        'decisionCode' => 'decisionCode',
        'licenseAssigned' => 'licenseAssigned',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->allowed) {
            $res['allowed'] = $this->allowed;
        }
        if (null !== $this->decisionCode) {
            $res['decisionCode'] = $this->decisionCode;
        }
        if (null !== $this->licenseAssigned) {
            $res['licenseAssigned'] = $this->licenseAssigned;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return EnsureUserLicenseAccessResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['allowed'])) {
            $model->allowed = $map['allowed'];
        }
        if (isset($map['decisionCode'])) {
            $model->decisionCode = $map['decisionCode'];
        }
        if (isset($map['licenseAssigned'])) {
            $model->licenseAssigned = $map['licenseAssigned'];
        }

        return $model;
    }
}
