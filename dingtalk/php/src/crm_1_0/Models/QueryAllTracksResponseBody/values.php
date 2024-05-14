<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryAllTracksResponseBody;

use AlibabaCloud\Tea\Model;

class values extends Model
{
    /**
     * @example 1234
     *
     * @var string
     */
    public $bizId;

    /**
     * @example manager1234
     *
     * @var string
     */
    public $creator;

    /**
     * @example customer_id
     *
     * @var string
     */
    public $customerId;

    /**
     * @example 1237126786127
     *
     * @var int
     */
    public $gmtCreate;

    /**
     * @description This parameter is required.
     *
     * @example asjkdh189127836
     *
     * @var string
     */
    public $id;

    /**
     * @example 4
     *
     * @var int
     */
    public $subType;

    /**
     * @example 80
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
