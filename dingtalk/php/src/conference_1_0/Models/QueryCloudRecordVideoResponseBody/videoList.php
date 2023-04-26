<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryCloudRecordVideoResponseBody;

use AlibabaCloud\Tea\Model;

class videoList extends Model
{
    /**
     * @example 59886
     *
     * @var int
     */
    public $duration;

    /**
     * @example 1631172094000
     *
     * @var int
     */
    public $endTime;

    /**
     * @example 1127942
     *
     * @var int
     */
    public $fileSize;

    /**
     * @example faa1566c5bc24f21821ae2394f82db2e
     *
     * @var string
     */
    public $mediaId;

    /**
     * @example 290882268xxx1172033231
     *
     * @var string
     */
    public $recordId;

    /**
     * @example 0
     *
     * @var int
     */
    public $recordType;

    /**
     * @example cn-shenzhen
     *
     * @var string
     */
    public $regionId;

    /**
     * @example 1631172094000
     *
     * @var int
     */
    public $startTime;

    /**
     * @example WFBkgJvtxxxxtSaA1jK4sgiEiE
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'duration'   => 'duration',
        'endTime'    => 'endTime',
        'fileSize'   => 'fileSize',
        'mediaId'    => 'mediaId',
        'recordId'   => 'recordId',
        'recordType' => 'recordType',
        'regionId'   => 'regionId',
        'startTime'  => 'startTime',
        'unionId'    => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->duration) {
            $res['duration'] = $this->duration;
        }
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->fileSize) {
            $res['fileSize'] = $this->fileSize;
        }
        if (null !== $this->mediaId) {
            $res['mediaId'] = $this->mediaId;
        }
        if (null !== $this->recordId) {
            $res['recordId'] = $this->recordId;
        }
        if (null !== $this->recordType) {
            $res['recordType'] = $this->recordType;
        }
        if (null !== $this->regionId) {
            $res['regionId'] = $this->regionId;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return videoList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['duration'])) {
            $model->duration = $map['duration'];
        }
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['fileSize'])) {
            $model->fileSize = $map['fileSize'];
        }
        if (isset($map['mediaId'])) {
            $model->mediaId = $map['mediaId'];
        }
        if (isset($map['recordId'])) {
            $model->recordId = $map['recordId'];
        }
        if (isset($map['recordType'])) {
            $model->recordType = $map['recordType'];
        }
        if (isset($map['regionId'])) {
            $model->regionId = $map['regionId'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
