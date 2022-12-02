<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryDoctorDetailsByJobNumberResponseBody\content;

use AlibabaCloud\Tea\Model;

class deptList extends Model
{
    /**
     * @description 科室大类名称
     *
     * @var string
     */
    public $categoryName;

    /**
     * @description 科室id
     *
     * @var int
     */
    public $deptId;

    /**
     * @description 科室名称
     *
     * @var string
     */
    public $deptName;

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
     * @description 人科关系关联id
     *
     * @var int
     */
    public $relationId;
    protected $_name = [
        'categoryName' => 'categoryName',
        'deptId'       => 'deptId',
        'deptName'     => 'deptName',
        'gmtCreate'    => 'gmtCreate',
        'gmtModified'  => 'gmtModified',
        'relationId'   => 'relationId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->categoryName) {
            $res['categoryName'] = $this->categoryName;
        }
        if (null !== $this->deptId) {
            $res['deptId'] = $this->deptId;
        }
        if (null !== $this->deptName) {
            $res['deptName'] = $this->deptName;
        }
        if (null !== $this->gmtCreate) {
            $res['gmtCreate'] = $this->gmtCreate;
        }
        if (null !== $this->gmtModified) {
            $res['gmtModified'] = $this->gmtModified;
        }
        if (null !== $this->relationId) {
            $res['relationId'] = $this->relationId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return deptList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['categoryName'])) {
            $model->categoryName = $map['categoryName'];
        }
        if (isset($map['deptId'])) {
            $model->deptId = $map['deptId'];
        }
        if (isset($map['deptName'])) {
            $model->deptName = $map['deptName'];
        }
        if (isset($map['gmtCreate'])) {
            $model->gmtCreate = $map['gmtCreate'];
        }
        if (isset($map['gmtModified'])) {
            $model->gmtModified = $map['gmtModified'];
        }
        if (isset($map['relationId'])) {
            $model->relationId = $map['relationId'];
        }

        return $model;
    }
}
