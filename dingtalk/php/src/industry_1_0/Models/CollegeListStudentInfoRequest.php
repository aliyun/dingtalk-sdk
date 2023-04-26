<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class CollegeListStudentInfoRequest extends Model
{
    /**
     * @var int
     */
    public $deptId;

    /**
     * @example UNCHECKED
     *
     * @var string
     */
    public $dingStudentStatus;

    /**
     * @example 10
     *
     * @var int
     */
    public $pageNumber;

    /**
     * @example 100
     *
     * @var int
     */
    public $pageSize;
    protected $_name = [
        'deptId'            => 'deptId',
        'dingStudentStatus' => 'dingStudentStatus',
        'pageNumber'        => 'pageNumber',
        'pageSize'          => 'pageSize',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptId) {
            $res['deptId'] = $this->deptId;
        }
        if (null !== $this->dingStudentStatus) {
            $res['dingStudentStatus'] = $this->dingStudentStatus;
        }
        if (null !== $this->pageNumber) {
            $res['pageNumber'] = $this->pageNumber;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CollegeListStudentInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptId'])) {
            $model->deptId = $map['deptId'];
        }
        if (isset($map['dingStudentStatus'])) {
            $model->dingStudentStatus = $map['dingStudentStatus'];
        }
        if (isset($map['pageNumber'])) {
            $model->pageNumber = $map['pageNumber'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }

        return $model;
    }
}
