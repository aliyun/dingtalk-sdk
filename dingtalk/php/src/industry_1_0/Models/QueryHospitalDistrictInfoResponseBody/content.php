<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryHospitalDistrictInfoResponseBody;

use AlibabaCloud\Tea\Model;

class content extends Model
{
    /**
     * @description 病区对应的物理地址
     *
     * @var string
     */
    public $address;

    /**
     * @description 删除，0:正常，其他：已删除
     *
     * @var int
     */
    public $deleted;

    /**
     * @description 院区或病区名称
     *
     * @var string
     */
    public $districtName;

    /**
     * @description 类型，1：院区；2：病区
     *
     * @var int
     */
    public $districtType;

    /**
     * @description 创建时间
     *
     * @var string
     */
    public $gmtCreate;

    /**
     * @description 修改时间
     *
     * @var string
     */
    public $gmtModified;

    /**
     * @description 主键
     *
     * @var int
     */
    public $id;

    /**
     * @description 院区id
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
