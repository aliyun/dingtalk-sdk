<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\GetJobInfoByJobIdResponseBody\jobOwners;
use AlibabaCloud\Tea\Model;

class GetJobInfoByJobIdResponseBody extends Model
{
    /**
     * @var int
     */
    public $createTime;

    /**
     * @var int
     */
    public $headCount;

    /**
     * @var string
     */
    public $jobId;

    /**
     * @var jobOwners[]
     */
    public $jobOwners;

    /**
     * @var int
     */
    public $mainDeptId;

    /**
     * @var string
     */
    public $mainDeptName;

    /**
     * @var string
     */
    public $name;
    protected $_name = [
        'createTime' => 'createTime',
        'headCount' => 'headCount',
        'jobId' => 'jobId',
        'jobOwners' => 'jobOwners',
        'mainDeptId' => 'mainDeptId',
        'mainDeptName' => 'mainDeptName',
        'name' => 'name',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
        }
        if (null !== $this->headCount) {
            $res['headCount'] = $this->headCount;
        }
        if (null !== $this->jobId) {
            $res['jobId'] = $this->jobId;
        }
        if (null !== $this->jobOwners) {
            $res['jobOwners'] = [];
            if (null !== $this->jobOwners && \is_array($this->jobOwners)) {
                $n = 0;
                foreach ($this->jobOwners as $item) {
                    $res['jobOwners'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->mainDeptId) {
            $res['mainDeptId'] = $this->mainDeptId;
        }
        if (null !== $this->mainDeptName) {
            $res['mainDeptName'] = $this->mainDeptName;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetJobInfoByJobIdResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['headCount'])) {
            $model->headCount = $map['headCount'];
        }
        if (isset($map['jobId'])) {
            $model->jobId = $map['jobId'];
        }
        if (isset($map['jobOwners'])) {
            if (!empty($map['jobOwners'])) {
                $model->jobOwners = [];
                $n = 0;
                foreach ($map['jobOwners'] as $item) {
                    $model->jobOwners[$n++] = null !== $item ? jobOwners::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['mainDeptId'])) {
            $model->mainDeptId = $map['mainDeptId'];
        }
        if (isset($map['mainDeptName'])) {
            $model->mainDeptName = $map['mainDeptName'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }

        return $model;
    }
}
