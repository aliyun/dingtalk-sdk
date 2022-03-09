<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models;

use AlibabaCloud\Tea\Model;
use GuzzleHttp\Psr7\Stream;

class UpdateKROfContentRequest extends Model
{
    /**
     * @var Stream
     */
    public $content;

    /**
     * @var Stream[]
     */
    public $updateQuoteList;

    /**
     * @description A short description of struct
     *
     * @var Stream
     */
    public $krId;

    /**
     * @var Stream
     */
    public $operatorUid;
    protected $_name = [
        'content'         => 'content',
        'updateQuoteList' => 'updateQuoteList',
        'krId'            => 'krId',
        'operatorUid'     => 'operatorUid',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->updateQuoteList) {
            $res['updateQuoteList'] = $this->updateQuoteList;
        }
        if (null !== $this->krId) {
            $res['krId'] = $this->krId;
        }
        if (null !== $this->operatorUid) {
            $res['operatorUid'] = $this->operatorUid;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateKROfContentRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['updateQuoteList'])) {
            if (!empty($map['updateQuoteList'])) {
                $model->updateQuoteList = $map['updateQuoteList'];
            }
        }
        if (isset($map['krId'])) {
            $model->krId = $map['krId'];
        }
        if (isset($map['operatorUid'])) {
            $model->operatorUid = $map['operatorUid'];
        }

        return $model;
    }
}
