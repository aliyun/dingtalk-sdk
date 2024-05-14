<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryTripProcessTemplatesRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example dingcd2016f425331dc1acaaa37764f94726
     *
     * @var string
     */
    public $customerCorpId;
    protected $_name = [
        'customerCorpId' => 'customerCorpId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->customerCorpId) {
            $res['customerCorpId'] = $this->customerCorpId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryTripProcessTemplatesRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['customerCorpId'])) {
            $model->customerCorpId = $map['customerCorpId'];
        }

        return $model;
    }
}
