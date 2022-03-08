<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\QueryPositionsResponseBody;

use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @description 所属职务ID
     *
     * @var string
     */
    public $jobId;

    /**
     * @description 职位类别ID
     *
     * @var string
     */
    public $positionCategoryId;

    /**
     * @description 职位描述
     *
     * @var string
     */
    public $positionDes;

    /**
     * @description 职位ID
     *
     * @var string
     */
    public $positionId;

    /**
     * @description 职位名称
     *
     * @var string
     */
    public $positionName;

    /**
     * @description 职位对应职级列表
     *
     * @var string[]
     */
    public $rankIdList;

    /**
     * @description 职位状态-0，启用；1，停用
     *
     * @var int
     */
    public $status;
    protected $_name = [
        'jobId'              => 'jobId',
        'positionCategoryId' => 'positionCategoryId',
        'positionDes'        => 'positionDes',
        'positionId'         => 'positionId',
        'positionName'       => 'positionName',
        'rankIdList'         => 'rankIdList',
        'status'             => 'status',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->jobId) {
            $res['jobId'] = $this->jobId;
        }
        if (null !== $this->positionCategoryId) {
            $res['positionCategoryId'] = $this->positionCategoryId;
        }
        if (null !== $this->positionDes) {
            $res['positionDes'] = $this->positionDes;
        }
        if (null !== $this->positionId) {
            $res['positionId'] = $this->positionId;
        }
        if (null !== $this->positionName) {
            $res['positionName'] = $this->positionName;
        }
        if (null !== $this->rankIdList) {
            $res['rankIdList'] = $this->rankIdList;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return list_
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['jobId'])) {
            $model->jobId = $map['jobId'];
        }
        if (isset($map['positionCategoryId'])) {
            $model->positionCategoryId = $map['positionCategoryId'];
        }
        if (isset($map['positionDes'])) {
            $model->positionDes = $map['positionDes'];
        }
        if (isset($map['positionId'])) {
            $model->positionId = $map['positionId'];
        }
        if (isset($map['positionName'])) {
            $model->positionName = $map['positionName'];
        }
        if (isset($map['rankIdList'])) {
            if (!empty($map['rankIdList'])) {
                $model->rankIdList = $map['rankIdList'];
            }
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }

        return $model;
    }
}
