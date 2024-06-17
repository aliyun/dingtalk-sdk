<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryRecentConversationsRequest extends Model
{
    /**
     * @var bool
     */
    public $onlyHuman;

    /**
     * @var bool
     */
    public $onlyInnerGroup;

    /**
     * @var string
     */
    public $userId;
    protected $_name = [
        'onlyHuman'      => 'onlyHuman',
        'onlyInnerGroup' => 'onlyInnerGroup',
        'userId'         => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->onlyHuman) {
            $res['onlyHuman'] = $this->onlyHuman;
        }
        if (null !== $this->onlyInnerGroup) {
            $res['onlyInnerGroup'] = $this->onlyInnerGroup;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryRecentConversationsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['onlyHuman'])) {
            $model->onlyHuman = $map['onlyHuman'];
        }
        if (isset($map['onlyInnerGroup'])) {
            $model->onlyInnerGroup = $map['onlyInnerGroup'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
