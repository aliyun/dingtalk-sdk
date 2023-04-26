<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryOfficialDatasetFieldsRequest extends Model
{
    /**
     * @example ding3xxx__-PROC-42FF6625-9692-4003-B13C-307CAACEC354
     *
     * @var string
     */
    public $dsId;

    /**
     * @example 12345
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'dsId'   => 'dsId',
        'userId' => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dsId) {
            $res['dsId'] = $this->dsId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryOfficialDatasetFieldsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dsId'])) {
            $model->dsId = $map['dsId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
