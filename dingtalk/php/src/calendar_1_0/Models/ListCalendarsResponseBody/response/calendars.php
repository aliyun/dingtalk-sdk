<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\ListCalendarsResponseBody\response;

use AlibabaCloud\Tea\Model;

class calendars extends Model
{
    /**
     * @description 日历id
     *
     * @var string
     */
    public $id;

    /**
     * @description 日历标题
     *
     * @var string
     */
    public $summary;

    /**
     * @description 日历描述
     *
     * @var string
     */
    public $description;

    /**
     * @description 时区
     *
     * @var string
     */
    public $timeZone;

    /**
     * @description Calendar资源的ETag，用于检测该Calendar以及内部的Event是否有被更新
     *
     * @var string
     */
    public $eTag;

    /**
     * @description 日历类型
     *
     * @var string
     */
    public $type;

    /**
     * @description 权限信息
     *
     * @var string
     */
    public $privilege;
    protected $_name = [
        'id'          => 'id',
        'summary'     => 'summary',
        'description' => 'description',
        'timeZone'    => 'timeZone',
        'eTag'        => 'eTag',
        'type'        => 'type',
        'privilege'   => 'privilege',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->summary) {
            $res['summary'] = $this->summary;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->timeZone) {
            $res['timeZone'] = $this->timeZone;
        }
        if (null !== $this->eTag) {
            $res['eTag'] = $this->eTag;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }
        if (null !== $this->privilege) {
            $res['privilege'] = $this->privilege;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return calendars
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['summary'])) {
            $model->summary = $map['summary'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['timeZone'])) {
            $model->timeZone = $map['timeZone'];
        }
        if (isset($map['eTag'])) {
            $model->eTag = $map['eTag'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }
        if (isset($map['privilege'])) {
            $model->privilege = $map['privilege'];
        }

        return $model;
    }
}
