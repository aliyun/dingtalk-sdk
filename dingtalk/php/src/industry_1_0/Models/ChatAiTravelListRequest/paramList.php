<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\ChatAiTravelListRequest;

use AlibabaCloud\Tea\Model;

class paramList extends Model
{
    /**
     * @example qaz1234567
     *
     * @var string
     */
    public $itineraryId;

    /**
     * @example {"lineNumber":1}
     *
     * @var string
     */
    public $value;
    protected $_name = [
        'itineraryId' => 'itineraryId',
        'value'       => 'value',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->itineraryId) {
            $res['itineraryId'] = $this->itineraryId;
        }
        if (null !== $this->value) {
            $res['value'] = $this->value;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return paramList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['itineraryId'])) {
            $model->itineraryId = $map['itineraryId'];
        }
        if (isset($map['value'])) {
            $model->value = $map['value'];
        }

        return $model;
    }
}
