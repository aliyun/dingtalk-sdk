<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryHospitalDistrictInfoResponseBody;

use AlibabaCloud\Tea\Model;

class content extends Model
{
    /**
     * @example 一楼
     *
     * @var string
     */
    public $address;

    /**
     * @example 0
     *
     * @var int
     */
    public $deleted;

    /**
     * @example 一病区
     *
     * @var string
     */
    public $districtName;

    /**
     * @example 1
     *
     * @var int
     */
    public $districtType;

    /**
     * @example 2021-12-22 15:30:31
     *
     * @var string
     */
    public $gmtCreate;

    /**
     * @example 2021-12-22 15:30:31
     *
     * @var string
     */
    public $gmtModified;

    /**
     * @example 123
     *
     * @var int
     */
    public $id;

    /**
     * @example 123
     *
     * @var int
     */
    public $parentDistrictId;
    protected $_name = [
        'address'          => 'address',
        'deleted'          => 'deleted',
        'districtName'     => 'districtName',
        'districtType'     => 'districtType',
        'gmtCreate'        => 'gmtCreate',
        'gmtModified'      => 'gmtModified',
        'id'               => 'id',
        'parentDistrictId' => 'parentDistrictId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->address) {
            $res['address'] = $this->address;
        }
        if (null !== $this->deleted) {
            $res['deleted'] = $this->deleted;
        }
        if (null !== $this->districtName) {
            $res['districtName'] = $this->districtName;
        }
        if (null !== $this->districtType) {
            $res['districtType'] = $this->districtType;
        }
        if (null !== $this->gmtCreate) {
            $res['gmtCreate'] = $this->gmtCreate;
        }
        if (null !== $this->gmtModified) {
            $res['gmtModified'] = $this->gmtModified;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->parentDistrictId) {
            $res['parentDistrictId'] = $this->parentDistrictId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return content
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['address'])) {
            $model->address = $map['address'];
        }
        if (isset($map['deleted'])) {
            $model->deleted = $map['deleted'];
        }
        if (isset($map['districtName'])) {
            $model->districtName = $map['districtName'];
        }
        if (isset($map['districtType'])) {
            $model->districtType = $map['districtType'];
        }
        if (isset($map['gmtCreate'])) {
            $model->gmtCreate = $map['gmtCreate'];
        }
        if (isset($map['gmtModified'])) {
            $model->gmtModified = $map['gmtModified'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['parentDistrictId'])) {
            $model->parentDistrictId = $map['parentDistrictId'];
        }

        return $model;
    }
}
