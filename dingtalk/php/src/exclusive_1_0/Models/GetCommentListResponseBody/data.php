<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetCommentListResponseBody;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @var string
     */
    public $commentId;

    /**
     * @var float
     */
    public $commentTime;

    /**
     * @var string
     */
    public $commentUserName;

    /**
     * @var string
     */
    public $content;
    protected $_name = [
        'commentId'       => 'commentId',
        'commentTime'     => 'commentTime',
        'commentUserName' => 'commentUserName',
        'content'         => 'content',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->commentId) {
            $res['commentId'] = $this->commentId;
        }
        if (null !== $this->commentTime) {
            $res['commentTime'] = $this->commentTime;
        }
        if (null !== $this->commentUserName) {
            $res['commentUserName'] = $this->commentUserName;
        }
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['commentId'])) {
            $model->commentId = $map['commentId'];
        }
        if (isset($map['commentTime'])) {
            $model->commentTime = $map['commentTime'];
        }
        if (isset($map['commentUserName'])) {
            $model->commentUserName = $map['commentUserName'];
        }
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }

        return $model;
    }
}
