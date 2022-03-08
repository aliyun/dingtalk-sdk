<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\ListEventsResponseBody\events;
use AlibabaCloud\Tea\Model;

class ListEventsResponseBody extends Model
{
    /**
     * @description 日程
     *
     * @var events[]
     */
    public $events;

    /**
     * @description 翻页token
     *
     * @var string
     */
    public $nextToken;

    /**
     * @description 增量同步token
     *
     * @var string
     */
    public $syncToken;
    protected $_name = [
        'events'    => 'events',
        'nextToken' => 'nextToken',
        'syncToken' => 'syncToken',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->events) {
            $res['events'] = [];
            if (null !== $this->events && \is_array($this->events)) {
                $n = 0;
                foreach ($this->events as $item) {
                    $res['events'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->syncToken) {
            $res['syncToken'] = $this->syncToken;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListEventsResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['events'])) {
            if (!empty($map['events'])) {
                $model->events = [];
                $n             = 0;
                foreach ($map['events'] as $item) {
                    $model->events[$n++] = null !== $item ? events::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['syncToken'])) {
            $model->syncToken = $map['syncToken'];
        }

        return $model;
    }
}
