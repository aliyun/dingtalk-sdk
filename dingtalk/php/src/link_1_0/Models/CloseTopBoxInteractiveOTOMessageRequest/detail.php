<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\CloseTopBoxInteractiveOTOMessageRequest;

use AlibabaCloud\Tea\Model;

class detail extends Model
{
    /**
     * @example service-card-20220824-001
     *
     * @var string
     */
    public $cardBizId;

    /**
     * @example 3erkfi-42b0-4c83-bc56-ffhssde43
     *
     * @var string
     */
    public $cardTemplateId;

    /**
     * @example user001
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'cardBizId'      => 'cardBizId',
        'cardTemplateId' => 'cardTemplateId',
        'userId'         => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->cardBizId) {
            $res['cardBizId'] = $this->cardBizId;
        }
        if (null !== $this->cardTemplateId) {
            $res['cardTemplateId'] = $this->cardTemplateId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return detail
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['cardBizId'])) {
            $model->cardBizId = $map['cardBizId'];
        }
        if (isset($map['cardTemplateId'])) {
            $model->cardTemplateId = $map['cardTemplateId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
