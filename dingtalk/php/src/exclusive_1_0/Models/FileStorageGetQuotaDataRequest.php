<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class FileStorageGetQuotaDataRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 2022-04
     *
     * @var string
     */
    public $endTime;

    /**
     * @description This parameter is required.
     *
     * @example 2021-04
     *
     * @var string
     */
    public $startTime;

    /**
     * @description This parameter is required.
     *
     * @example ding77b8cac4e026cc123xxxxxxxxeb6378f
     *
     * @var string
     */
    public $targetCorpId;

    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var string
     */
    public $type;
    protected $_name = [
        'endTime' => 'endTime',
        'startTime' => 'startTime',
        'targetCorpId' => 'targetCorpId',
        'type' => 'type',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->targetCorpId) {
            $res['targetCorpId'] = $this->targetCorpId;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return FileStorageGetQuotaDataRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['targetCorpId'])) {
            $model->targetCorpId = $map['targetCorpId'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
