<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models;

use AlibabaCloud\Tea\Model;

class PushEventRequest extends Model
{
    /**
     * @description 钉钉物联组织ID, 第三方平台必填，企业内部系统忽略。
     *
     * @var string
     */
    public $corpId;

    /**
     * @description 事件ID。
     *
     * @var string
     */
    public $eventId;

    /**
     * @description 事件类型，最长20个字符。
     *
     * @var string
     */
    public $eventType;

    /**
     * @description 事件名称，长度4-20个字符，一个中文汉字算2个字符。
     *
     * @var string
     */
    public $eventName;

    /**
     * @description 事件发生事件，Unix时间戳，单位毫秒。
     *
     * @var int
     */
    public $occurrenceTime;

    /**
     * @description 触发事件设备ID。
     *
     * @var string
     */
    public $deviceId;

    /**
     * @description 事件发生地点。
     *
     * @var string
     */
    public $location;

    /**
     * @description 事件文字信息。
     *
     * @var string
     */
    public $msg;

    /**
     * @description 事件图片地址列表。
     *
     * @var string[]
     */
    public $picUrls;

    /**
     * @description 第三方平台定制参数，企业内部系统忽略。
     *
     * @var mixed[]
     */
    public $extraData;
    protected $_name = [
        'corpId'         => 'corpId',
        'eventId'        => 'eventId',
        'eventType'      => 'eventType',
        'eventName'      => 'eventName',
        'occurrenceTime' => 'occurrenceTime',
        'deviceId'       => 'deviceId',
        'location'       => 'location',
        'msg'            => 'msg',
        'picUrls'        => 'picUrls',
        'extraData'      => 'extraData',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->eventId) {
            $res['eventId'] = $this->eventId;
        }
        if (null !== $this->eventType) {
            $res['eventType'] = $this->eventType;
        }
        if (null !== $this->eventName) {
            $res['eventName'] = $this->eventName;
        }
        if (null !== $this->occurrenceTime) {
            $res['occurrenceTime'] = $this->occurrenceTime;
        }
        if (null !== $this->deviceId) {
            $res['deviceId'] = $this->deviceId;
        }
        if (null !== $this->location) {
            $res['location'] = $this->location;
        }
        if (null !== $this->msg) {
            $res['msg'] = $this->msg;
        }
        if (null !== $this->picUrls) {
            $res['picUrls'] = $this->picUrls;
        }
        if (null !== $this->extraData) {
            $res['extraData'] = $this->extraData;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PushEventRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['eventId'])) {
            $model->eventId = $map['eventId'];
        }
        if (isset($map['eventType'])) {
            $model->eventType = $map['eventType'];
        }
        if (isset($map['eventName'])) {
            $model->eventName = $map['eventName'];
        }
        if (isset($map['occurrenceTime'])) {
            $model->occurrenceTime = $map['occurrenceTime'];
        }
        if (isset($map['deviceId'])) {
            $model->deviceId = $map['deviceId'];
        }
        if (isset($map['location'])) {
            $model->location = $map['location'];
        }
        if (isset($map['msg'])) {
            $model->msg = $map['msg'];
        }
        if (isset($map['picUrls'])) {
            if (!empty($map['picUrls'])) {
                $model->picUrls = $map['picUrls'];
            }
        }
        if (isset($map['extraData'])) {
            $model->extraData = $map['extraData'];
        }

        return $model;
    }
}
