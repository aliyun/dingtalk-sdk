<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class AddContactHideBySceneSettingResponseBody extends Model
{
    /**
     * @description settingId
     *
     * @var int
     */
    public $settingId;
    protected $_name = [
        'settingId' => 'settingId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->settingId) {
            $res['settingId'] = $this->settingId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddContactHideBySceneSettingResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['settingId'])) {
            $model->settingId = $map['settingId'];
        }

        return $model;
    }
}
