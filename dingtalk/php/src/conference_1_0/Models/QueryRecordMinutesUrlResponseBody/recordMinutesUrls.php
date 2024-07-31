<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryRecordMinutesUrlResponseBody;

use AlibabaCloud\Tea\Model;

class recordMinutesUrls extends Model
{
    /**
     * @var string
     */
    public $recordMinutesUrl;
    protected $_name = [
        'recordMinutesUrl' => 'recordMinutesUrl',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->recordMinutesUrl) {
            $res['recordMinutesUrl'] = $this->recordMinutesUrl;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return recordMinutesUrls
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['recordMinutesUrl'])) {
            $model->recordMinutesUrl = $map['recordMinutesUrl'];
        }

        return $model;
    }
}
