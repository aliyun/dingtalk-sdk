<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryMedicalEventsResponseBody;

use AlibabaCloud\Tea\Model;

class content extends Model
{
    /**
     * @var string
     */
    public $code;

    /**
     * @var string
     */
    public $content;

    /**
     * @var int
     */
    public $eventId;
    protected $_name = [
        'code'    => 'code',
        'content' => 'content',
        'eventId' => 'eventId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->code) {
            $res['code'] = $this->code;
        }
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->eventId) {
            $res['eventId'] = $this->eventId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return content
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['code'])) {
            $model->code = $map['code'];
        }
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['eventId'])) {
            $model->eventId = $map['eventId'];
        }

        return $model;
    }
}
