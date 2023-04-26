<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\ListCalendarsResponseBody\response;

use AlibabaCloud\Tea\Model;

class calendars extends Model
{
    /**
     * @var string
     */
    public $description;

    /**
     * @var string
     */
    public $eTag;

    /**
     * @var string
     */
    public $id;

    /**
     * @var string
     */
    public $privilege;

    /**
     * @var string
     */
    public $summary;

    /**
     * @var string
     */
    public $timeZone;

    /**
     * @var string
     */
    public $type;
    protected $_name = [
        'description' => 'description',
        'eTag'        => 'eTag',
        'id'          => 'id',
        'privilege'   => 'privilege',
        'summary'     => 'summary',
        'timeZone'    => 'timeZone',
        'type'        => 'type',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->eTag) {
            $res['eTag'] = $this->eTag;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->privilege) {
            $res['privilege'] = $this->privilege;
        }
        if (null !== $this->summary) {
            $res['summary'] = $this->summary;
        }
        if (null !== $this->timeZone) {
            $res['timeZone'] = $this->timeZone;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
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
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['eTag'])) {
            $model->eTag = $map['eTag'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['privilege'])) {
            $model->privilege = $map['privilege'];
        }
        if (isset($map['summary'])) {
            $model->summary = $map['summary'];
        }
        if (isset($map['timeZone'])) {
            $model->timeZone = $map['timeZone'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
