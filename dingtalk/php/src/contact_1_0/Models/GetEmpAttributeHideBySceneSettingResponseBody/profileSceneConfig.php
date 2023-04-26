<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetEmpAttributeHideBySceneSettingResponseBody;

use AlibabaCloud\Tea\Model;

class profileSceneConfig extends Model
{
    /**
     * @var bool
     */
    public $active;
    protected $_name = [
        'active' => 'active',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->active) {
            $res['active'] = $this->active;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return profileSceneConfig
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['active'])) {
            $model->active = $map['active'];
        }

        return $model;
    }
}
