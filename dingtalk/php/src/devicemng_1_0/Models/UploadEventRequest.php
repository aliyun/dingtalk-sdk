<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models;

use AlibabaCloud\Tea\Model;

class UploadEventRequest extends Model
{
    /**
     * @var string
     */
    public $deviceUuid;

    /**
     * @var string
     */
    public $content;

    /**
     * @var string
     */
    public $dingCorpId;

    /**
     * @var string
     */
    public $deviceCode;

    /**
     * @var string
     */
    public $level;

    /**
     * @var string
     */
    public $eventTime;

    /**
     * @var string
     */
    public $eventType;

    /**
     * @var string
     */
    public $coverUrl;
    protected $_name = [
        'deviceUuid' => 'deviceUuid',
        'content'    => 'content',
        'dingCorpId' => 'dingCorpId',
        'deviceCode' => 'deviceCode',
        'level'      => 'level',
        'eventTime'  => 'eventTime',
        'eventType'  => 'eventType',
        'coverUrl'   => 'coverUrl',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deviceUuid) {
            $res['deviceUuid'] = $this->deviceUuid;
        }
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->dingCorpId) {
            $res['dingCorpId'] = $this->dingCorpId;
        }
        if (null !== $this->deviceCode) {
            $res['deviceCode'] = $this->deviceCode;
        }
        if (null !== $this->level) {
            $res['level'] = $this->level;
        }
        if (null !== $this->eventTime) {
            $res['eventTime'] = $this->eventTime;
        }
        if (null !== $this->eventType) {
            $res['eventType'] = $this->eventType;
        }
        if (null !== $this->coverUrl) {
            $res['coverUrl'] = $this->coverUrl;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UploadEventRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deviceUuid'])) {
            $model->deviceUuid = $map['deviceUuid'];
        }
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['dingCorpId'])) {
            $model->dingCorpId = $map['dingCorpId'];
        }
        if (isset($map['deviceCode'])) {
            $model->deviceCode = $map['deviceCode'];
        }
        if (isset($map['level'])) {
            $model->level = $map['level'];
        }
        if (isset($map['eventTime'])) {
            $model->eventTime = $map['eventTime'];
        }
        if (isset($map['eventType'])) {
            $model->eventType = $map['eventType'];
        }
        if (isset($map['coverUrl'])) {
            $model->coverUrl = $map['coverUrl'];
        }

        return $model;
    }
}
