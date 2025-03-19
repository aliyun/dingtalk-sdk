<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vai_paa_s_1_0\Models\ExclusiveModelCompleteServiceResponseBody\choices;

use AlibabaCloud\Tea\Model;

class message extends Model
{
    /**
     * @var string
     */
    public $content;

    /**
     * @var string
     */
    public $reasoningContent;

    /**
     * @var string
     */
    public $role;
    protected $_name = [
        'content' => 'content',
        'reasoningContent' => 'reasoning_content',
        'role' => 'role',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->reasoningContent) {
            $res['reasoning_content'] = $this->reasoningContent;
        }
        if (null !== $this->role) {
            $res['role'] = $this->role;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return message
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['reasoning_content'])) {
            $model->reasoningContent = $map['reasoning_content'];
        }
        if (isset($map['role'])) {
            $model->role = $map['role'];
        }

        return $model;
    }
}
