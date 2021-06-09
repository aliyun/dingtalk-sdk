<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryConferenceInfoBatchRequest extends Model
{
    /**
     * @var string[]
     */
    public $conferenceIdList;
    protected $_name = [
        'conferenceIdList' => 'conferenceIdList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->conferenceIdList) {
            $res['conferenceIdList'] = $this->conferenceIdList;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryConferenceInfoBatchRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['conferenceIdList'])) {
            if (!empty($map['conferenceIdList'])) {
                $model->conferenceIdList = $map['conferenceIdList'];
            }
        }

        return $model;
    }
}
