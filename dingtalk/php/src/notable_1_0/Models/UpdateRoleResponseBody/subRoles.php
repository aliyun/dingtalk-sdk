<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\UpdateRoleResponseBody;

use AlibabaCloud\Tea\Model;

class subRoles extends Model
{
    /**
     * @var int
     */
    public $authLevel;

    /**
     * @var int
     */
    public $bizType;

    /**
     * @var string
     */
    public $config;

    /**
     * @var int
     */
    public $gmtCreate;

    /**
     * @var string
     */
    public $id;
    protected $_name = [
        'authLevel' => 'authLevel',
        'bizType' => 'bizType',
        'config' => 'config',
        'gmtCreate' => 'gmtCreate',
        'id' => 'id',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->authLevel) {
            $res['authLevel'] = $this->authLevel;
        }
        if (null !== $this->bizType) {
            $res['bizType'] = $this->bizType;
        }
        if (null !== $this->config) {
            $res['config'] = $this->config;
        }
        if (null !== $this->gmtCreate) {
            $res['gmtCreate'] = $this->gmtCreate;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return subRoles
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['authLevel'])) {
            $model->authLevel = $map['authLevel'];
        }
        if (isset($map['bizType'])) {
            $model->bizType = $map['bizType'];
        }
        if (isset($map['config'])) {
            $model->config = $map['config'];
        }
        if (isset($map['gmtCreate'])) {
            $model->gmtCreate = $map['gmtCreate'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }

        return $model;
    }
}
