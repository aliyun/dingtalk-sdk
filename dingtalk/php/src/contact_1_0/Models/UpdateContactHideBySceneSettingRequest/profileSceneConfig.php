<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\UpdateContactHideBySceneSettingRequest;

use AlibabaCloud\Tea\Model;

class profileSceneConfig extends Model
{
    /**
     * @description 是否在用户详情页面生效，默认为true。如果为false，仍然允许查看个人资料页中的员工信息。
     *
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
