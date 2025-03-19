<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\TaskInfoCreateAndStartTaskRequest;

use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\TaskInfoCreateAndStartTaskRequest\backlogDTO\content;
use AlibabaCloud\Tea\Model;

class backlogDTO extends Model
{
    /**
     * @var content
     */
    public $content;
    protected $_name = [
        'content' => 'content',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->content) {
            $res['content'] = null !== $this->content ? $this->content->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return backlogDTO
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['content'])) {
            $model->content = content::fromMap($map['content']);
        }

        return $model;
    }
}
