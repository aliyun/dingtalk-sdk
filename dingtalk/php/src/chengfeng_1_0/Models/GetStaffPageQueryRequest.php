<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetStaffPageQueryRequest extends Model
{
    /**
     * @description 部门编码
     *
     * @var string
     */
    public $deptCode;

    /**
     * @description 员工名称,模糊查询
     *
     * @var string
     */
    public $name;

    /**
     * @description 当前页码
     *
     * @var int
     */
    public $pageNumber;

    /**
     * @description 分页条数
     *
     * @var int
     */
    public $pageSize;

    /**
     * @description 工号
     *
     * @var string
     */
    public $workNo;
    protected $_name = [
        'deptCode'   => 'deptCode',
        'name'       => 'name',
        'pageNumber' => 'pageNumber',
        'pageSize'   => 'pageSize',
        'workNo'     => 'workNo',
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
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->pageNumber) {
            $res['pageNumber'] = $this->pageNumber;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }
        if (null !== $this->workNo) {
            $res['workNo'] = $this->workNo;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetStaffPageQueryRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptCode'])) {
            $model->deptCode = $map['deptCode'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['pageNumber'])) {
            $model->pageNumber = $map['pageNumber'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }
        if (isset($map['workNo'])) {
            $model->workNo = $map['workNo'];
        }

        return $model;
    }
}
