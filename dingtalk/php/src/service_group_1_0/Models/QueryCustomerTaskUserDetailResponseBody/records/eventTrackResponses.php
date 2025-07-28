<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QueryCustomerTaskUserDetailResponseBody\records;

use AlibabaCloud\Tea\Model;

class eventTrackResponses extends Model
{
    /**
     * @example 2023-07-14 00:00:00
     *
     * @var string
     */
    public $clickTime;

    /**
     * @example 88888
     *
     * @var string
     */
    public $eventTrackId;

    /**
     * @example true
     *
     * @var bool
     */
    public $onClick;

    /**
     * @example 标题名称
     *
     * @var string
     */
    public $title;
    protected $_name = [
        'clickTime' => 'clickTime',
        'eventTrackId' => 'eventTrackId',
        'onClick' => 'onClick',
        'title' => 'title',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->clickTime) {
            $res['clickTime'] = $this->clickTime;
        }
        if (null !== $this->eventTrackId) {
            $res['eventTrackId'] = $this->eventTrackId;
        }
        if (null !== $this->onClick) {
            $res['onClick'] = $this->onClick;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return eventTrackResponses
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['clickTime'])) {
            $model->clickTime = $map['clickTime'];
        }
        if (isset($map['eventTrackId'])) {
            $model->eventTrackId = $map['eventTrackId'];
        }
        if (isset($map['onClick'])) {
            $model->onClick = $map['onClick'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}
