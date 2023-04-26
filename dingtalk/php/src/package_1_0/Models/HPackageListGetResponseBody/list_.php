<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vpackage_1_0\Models\HPackageListGetResponseBody;

use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @example 1
     *
     * @var int
     */
    public $avaliable;

    /**
     * @var string
     */
    public $creator;

    /**
     * @var bool
     */
    public $finished;

    /**
     * @example 1669261911344
     *
     * @var int
     */
    public $operationTime;

    /**
     * @example 100
     *
     * @var int
     */
    public $packageSize;

    /**
     * @example 1
     *
     * @var string
     */
    public $status;

    /**
     * @example 00000000Azksf
     *
     * @var string
     */
    public $taskId;

    /**
     * @example 0.0.1
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
