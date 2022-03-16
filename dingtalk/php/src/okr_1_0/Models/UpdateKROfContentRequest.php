<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateKROfContentRequest extends Model
{
    /**
     * @description KR的内容。
     *
     * @var string
     */
    public $content;

    /**
     * @description 待更新的划词 ID 列表。
     *
     * @var string[]
     */
    public $updateQuoteList;

    /**
     * @description 当前 KR ID。
     *
     * @var string
     */
    public $krId;

    /**
     * @description 当前用户的userId。
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'content'         => 'content',
        'updateQuoteList' => 'updateQuoteList',
        'krId'            => 'krId',
        'userId'          => 'userId',
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
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
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
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
