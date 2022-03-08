<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\GetResidentUserInfoResponseBody\roles;
use AlibabaCloud\Tea\Model;

class GetResidentUserInfoResponseBody extends Model
{
    /**
     * @description 员工特征
     *
     * @var string
     */
    public $feature;

    /**
     * @description 员工名字
     *
     * @var string
     */
    public $name;

    /**
     * @description 标签列表
     *
     * @var roles[]
     */
    public $roles;

    /**
     * @description 钉钉唯一标识
     *
     * @var string
     */
    public $unionId;

    /**
     * @description 员工id
     *
     * @var string
     */
    public $userid;
    protected $_name = [
        'feature' => 'feature',
        'name'    => 'name',
        'roles'   => 'roles',
        'unionId' => 'unionId',
        'userid'  => 'userid',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->feature) {
            $res['feature'] = $this->feature;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->roles) {
            $res['roles'] = [];
            if (null !== $this->roles && \is_array($this->roles)) {
                $n = 0;
                foreach ($this->roles as $item) {
                    $res['roles'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }
        if (null !== $this->userid) {
            $res['userid'] = $this->userid;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetResidentUserInfoResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['feature'])) {
            $model->feature = $map['feature'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['roles'])) {
            if (!empty($map['roles'])) {
                $model->roles = [];
                $n            = 0;
                foreach ($map['roles'] as $item) {
                    $model->roles[$n++] = null !== $item ? roles::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }
        if (isset($map['userid'])) {
            $model->userid = $map['userid'];
        }

        return $model;
    }
}
