<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllDepartmentResponseBody\content\deptAndExt;

use AlibabaCloud\Tea\Model;

class extendInfos extends Model
{
    /**
     * @description 部门code
     *
     * @var string
     */
    public $deptCode;

    /**
     * @description 科室扩展字段描述
     *
     * @var string
     */
    public $deptExtendDisplayName;

    /**
     * @description 科室扩展字段key
     *
     * @var string
     */
    public $deptExtendKey;

    /**
     * @description 科室扩展字段value
     *
     * @var string
     */
    public $deptExtendValue;

    /**
     * @description 创建时间
     *
     * @var string
     */
    public $gmtCreateStr;

    /**
     * @description 修改时间
     *
     * @var string
     */
    public $gmtModifiedStr;

    /**
     * @description 扩展信息id
     *
     * @var int
     */
    public $id;

    /**
     * @description 0-有效 ，1-无效
     *
     * @var int
     */
    public $status;
    protected $_name = [
        'deptCode'              => 'deptCode',
        'deptExtendDisplayName' => 'deptExtendDisplayName',
        'deptExtendKey'         => 'deptExtendKey',
        'deptExtendValue'       => 'deptExtendValue',
        'gmtCreateStr'          => 'gmtCreateStr',
        'gmtModifiedStr'        => 'gmtModifiedStr',
        'id'                    => 'id',
        'status'                => 'status',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptCode) {
            $res['deptCode'] = $this->deptCode;
        }
        if (null !== $this->deptExtendDisplayName) {
            $res['deptExtendDisplayName'] = $this->deptExtendDisplayName;
        }
        if (null !== $this->deptExtendKey) {
            $res['deptExtendKey'] = $this->deptExtendKey;
        }
        if (null !== $this->deptExtendValue) {
            $res['deptExtendValue'] = $this->deptExtendValue;
        }
        if (null !== $this->gmtCreateStr) {
            $res['gmtCreateStr'] = $this->gmtCreateStr;
        }
        if (null !== $this->gmtModifiedStr) {
            $res['gmtModifiedStr'] = $this->gmtModifiedStr;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return extendInfos
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptCode'])) {
            $model->deptCode = $map['deptCode'];
        }
        if (isset($map['deptExtendDisplayName'])) {
            $model->deptExtendDisplayName = $map['deptExtendDisplayName'];
        }
        if (isset($map['deptExtendKey'])) {
            $model->deptExtendKey = $map['deptExtendKey'];
        }
        if (isset($map['deptExtendValue'])) {
            $model->deptExtendValue = $map['deptExtendValue'];
        }
        if (isset($map['gmtCreateStr'])) {
            $model->gmtCreateStr = $map['gmtCreateStr'];
        }
        if (isset($map['gmtModifiedStr'])) {
            $model->gmtModifiedStr = $map['gmtModifiedStr'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }

        return $model;
    }
}
