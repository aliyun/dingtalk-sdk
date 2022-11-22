<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vevent_1_0\Models\GetCallBackFaileResultResponseBody;

use AlibabaCloud\Tea\Model;

class failedList extends Model
{
    /**
     * @description 返回的事件内容
     *
     * @var string
     */
    public $callBackData;

    /**
     * @description 事件类型
     *
     * @var string
     */
    public $callBackTag;

    /**
     * @description 事件所属的corpId
     *
     * @var string
     */
    public $corpId;

    /**
     * @description 事件的时间戳。
     *
     * @var int
     */
    public $eventTime;
    protected $_name = [
        'callBackData' => 'callBackData',
        'callBackTag'  => 'callBackTag',
        'corpId'       => 'corpId',
        'eventTime'    => 'eventTime',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->callBackData) {
            $res['callBackData'] = $this->callBackData;
        }
        if (null !== $this->callBackTag) {
            $res['callBackTag'] = $this->callBackTag;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->eventTime) {
            $res['eventTime'] = $this->eventTime;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return failedList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['callBackData'])) {
            $model->callBackData = $map['callBackData'];
        }
        if (isset($map['callBackTag'])) {
            $model->callBackTag = $map['callBackTag'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['eventTime'])) {
            $model->eventTime = $map['eventTime'];
        }

        return $model;
    }
}
