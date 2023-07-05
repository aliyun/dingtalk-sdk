<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryScheduleConferenceRequest extends Model
{
    /**
     * @example qzR1iSMDvzR9iP7Pxxxxxxxxxxxx
     *
     * @var string
     */
    public $requestUnionId;
    protected $_name = [
        'requestUnionId' => 'requestUnionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->requestUnionId) {
            $res['requestUnionId'] = $this->requestUnionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryScheduleConferenceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['requestUnionId'])) {
            $model->requestUnionId = $map['requestUnionId'];
        }

        return $model;
    }
}
