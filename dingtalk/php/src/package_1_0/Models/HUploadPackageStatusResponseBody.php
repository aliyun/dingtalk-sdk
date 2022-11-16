<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vpackage_1_0\Models;

use AlibabaCloud\Tea\Model;

class HUploadPackageStatusResponseBody extends Model
{
    /**
     * @description 创建时间
     *
     * @var int
     */
    public $buildTime;

    /**
     * @description 任务是否已结束
     *
     * @var bool
     */
    public $finished;

    /**
     * @description H5离线包体积，单位Byte
     *
     * @var int
     */
    public $packageSize;

    /**
     * @description 任务状态。1：构建中；2：成功；3：失败；5：超时。
     *
     * @var string
     */
    public $status;

    /**
     * @description 创建离线包接口返回的taskId
     *
     * @var string
     */
    public $taskId;

    /**
     * @description H5离线包版本号
     *
     * @var string
     */
    public $version;
    protected $_name = [
        'buildTime'   => 'buildTime',
        'finished'    => 'finished',
        'packageSize' => 'packageSize',
        'status'      => 'status',
        'taskId'      => 'taskId',
        'version'     => 'version',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->buildTime) {
            $res['buildTime'] = $this->buildTime;
        }
        if (null !== $this->finished) {
            $res['finished'] = $this->finished;
        }
        if (null !== $this->packageSize) {
            $res['packageSize'] = $this->packageSize;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->taskId) {
            $res['taskId'] = $this->taskId;
        }
        if (null !== $this->version) {
            $res['version'] = $this->version;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return HUploadPackageStatusResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['buildTime'])) {
            $model->buildTime = $map['buildTime'];
        }
        if (isset($map['finished'])) {
            $model->finished = $map['finished'];
        }
        if (isset($map['packageSize'])) {
            $model->packageSize = $map['packageSize'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['taskId'])) {
            $model->taskId = $map['taskId'];
        }
        if (isset($map['version'])) {
            $model->version = $map['version'];
        }

        return $model;
    }
}
