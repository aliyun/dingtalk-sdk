<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vflashmeeting_1_0\Models\GetShanhuiByCalendarResponseBody\result;

use AlibabaCloud\Tea\Model;

class topics extends Model
{
    /**
     * @example 27Hio9BV23Ghj8LkRe34QzSdP94UtMkju
     *
     * @var string
     */
    public $docKey;

    /**
     * @example 会议1
     *
     * @var string
     */
    public $title;
    protected $_name = [
        'docKey' => 'docKey',
        'title'  => 'title',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->docKey) {
            $res['docKey'] = $this->docKey;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return topics
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['docKey'])) {
            $model->docKey = $map['docKey'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}
