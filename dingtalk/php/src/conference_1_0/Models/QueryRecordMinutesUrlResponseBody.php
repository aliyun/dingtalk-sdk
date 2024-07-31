<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryRecordMinutesUrlResponseBody\recordMinutesUrls;
use AlibabaCloud\Tea\Model;

class QueryRecordMinutesUrlResponseBody extends Model
{
    /**
     * @var recordMinutesUrls[]
     */
    public $recordMinutesUrls;
    protected $_name = [
        'recordMinutesUrls' => 'recordMinutesUrls',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->recordMinutesUrls) {
            $res['recordMinutesUrls'] = [];
            if (null !== $this->recordMinutesUrls && \is_array($this->recordMinutesUrls)) {
                $n = 0;
                foreach ($this->recordMinutesUrls as $item) {
                    $res['recordMinutesUrls'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryRecordMinutesUrlResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['recordMinutesUrls'])) {
            if (!empty($map['recordMinutesUrls'])) {
                $model->recordMinutesUrls = [];
                $n                        = 0;
                foreach ($map['recordMinutesUrls'] as $item) {
                    $model->recordMinutesUrls[$n++] = null !== $item ? recordMinutesUrls::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
