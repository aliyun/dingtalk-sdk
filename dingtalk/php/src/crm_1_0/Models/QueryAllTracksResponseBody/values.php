<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryAllTracksResponseBody;

use AlibabaCloud\Tea\Model;

class values extends Model
{
    /**
     * @description 动态外键
     *
     * @var string
     */
    public $bizId;

    /**
     * @description 创建人userId
     *
     * @var string
     */
    public $creator;

    /**
     * @description 客户id
     *
     * @var string
     */
    public $customerId;

    /**
     * @description 创建时间
     *
     * @var int
     */
    public $gmtCreate;

    /**
     * @description 动态加密主键
     *
     * @var string
     */
    public $id;

    /**
     * @description 动态子类型
     *
     * @var int
     */
    public $subType;

    /**
     * @description 动态类型
     *
     * @var int
     */
    public $type;
    protected $_name = [
        'bizId'      => 'bizId',
        'creator'    => 'creator',
        'customerId' => 'customerId',
        'gmtCreate'  => 'gmtCreate',
        'id'         => 'id',
        'subType'    => 'subType',
        'type'       => 'type',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizId) {
            $res['bizId'] = $this->bizId;
        }
        if (null !== $this->creator) {
            $res['creator'] = $this->creator;
        }
        if (null !== $this->customerId) {
            $res['customerId'] = $this->customerId;
        }
        if (null !== $this->gmtCreate) {
            $res['gmtCreate'] = $this->gmtCreate;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->subType) {
            $res['subType'] = $this->subType;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return values
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizId'])) {
            $model->bizId = $map['bizId'];
        }
        if (isset($map['creator'])) {
            $model->creator = $map['creator'];
        }
        if (isset($map['customerId'])) {
            $model->customerId = $map['customerId'];
        }
        if (isset($map['gmtCreate'])) {
            $model->gmtCreate = $map['gmtCreate'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['subType'])) {
            $model->subType = $map['subType'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
