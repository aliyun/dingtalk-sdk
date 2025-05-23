<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class SendAppDingRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 开会
     *
     * @var string
     */
    public $content;

    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $userids;
    protected $_name = [
        'content' => 'content',
        'userids' => 'userids',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->userids) {
            $res['userids'] = $this->userids;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SendAppDingRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['userids'])) {
            if (!empty($map['userids'])) {
                $model->userids = $map['userids'];
            }
        }

        return $model;
    }
}
