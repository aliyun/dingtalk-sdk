<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryAllTracksResponseBody;

use AlibabaCloud\Tea\Model;

class values extends Model
{
    /**
     * @description 企业id
     *
     * @var string
     */
    public $corpId;

    /**
     * @description 客户id
     *
     * @var string
     */
    public $customerId;

    /**
     * @description 动态类型
     *
     * @var int
     */
    public $type;

    /**
     * @description 动态子类型
     *
     * @var int
     */
    public $subType;

    /**
     * @description 创建时间
     *
     * @var int
     */
    public $gmtCreate;

    /**
     * @description 创建人userId
     *
     * @var string
     */
    public $creator;

    /**
     * @description 动态外键
     *
     * @var string
     */
    public $bizId;
    protected $_name = [
        'corpId'     => 'corpId',
        'customerId' => 'customerId',
        'type'       => 'type',
        'subType'    => 'subType',
        'gmtCreate'  => 'gmtCreate',
        'creator'    => 'creator',
        'bizId'      => 'bizId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->customerId) {
            $res['customerId'] = $this->customerId;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }
        if (null !== $this->subType) {
            $res['subType'] = $this->subType;
        }
        if (null !== $this->gmtCreate) {
            $res['gmtCreate'] = $this->gmtCreate;
        }
        if (null !== $this->creator) {
            $res['creator'] = $this->creator;
        }
        if (null !== $this->bizId) {
            $res['bizId'] = $this->bizId;
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
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['customerId'])) {
            $model->customerId = $map['customerId'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }
        if (isset($map['subType'])) {
            $model->subType = $map['subType'];
        }
        if (isset($map['gmtCreate'])) {
            $model->gmtCreate = $map['gmtCreate'];
        }
        if (isset($map['creator'])) {
            $model->creator = $map['creator'];
        }
        if (isset($map['bizId'])) {
            $model->bizId = $map['bizId'];
        }

        return $model;
    }
}
