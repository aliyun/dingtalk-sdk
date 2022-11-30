<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vpackage_1_0\Models\HPackageListGetResponseBody;

use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @description 版本是否可用
     *
     * @var int
     */
    public $avaliable;

    /**
     * @description 上传者
     *
     * @var string
     */
    public $creator;

    /**
     * @description 上传是否已完成
     *
     * @var bool
     */
    public $finished;

    /**
     * @description 上传时间
     *
     * @var int
     */
    public $operationTime;

    /**
     * @description 离线包大小，单位byte
     *
     * @var int
     */
    public $packageSize;

    /**
     * @description 版本状态
     *
     * @var string
     */
    public $status;

    /**
     * @description 上传任务ID
     *
     * @var string
     */
    public $taskId;

    /**
     * @description 版本号
     *
     * @var string
     */
    public $version;
    protected $_name = [
        'avaliable'     => 'avaliable',
        'creator'       => 'creator',
        'finished'      => 'finished',
        'operationTime' => 'operationTime',
        'packageSize'   => 'packageSize',
        'status'        => 'status',
        'taskId'        => 'taskId',
        'version'       => 'version',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->avaliable) {
            $res['avaliable'] = $this->avaliable;
        }
        if (null !== $this->creator) {
            $res['creator'] = $this->creator;
        }
        if (null !== $this->finished) {
            $res['finished'] = $this->finished;
        }
        if (null !== $this->operationTime) {
            $res['operationTime'] = $this->operationTime;
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
     * @return list_
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['avaliable'])) {
            $model->avaliable = $map['avaliable'];
        }
        if (isset($map['creator'])) {
            $model->creator = $map['creator'];
        }
        if (isset($map['finished'])) {
            $model->finished = $map['finished'];
        }
        if (isset($map['operationTime'])) {
            $model->operationTime = $map['operationTime'];
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
