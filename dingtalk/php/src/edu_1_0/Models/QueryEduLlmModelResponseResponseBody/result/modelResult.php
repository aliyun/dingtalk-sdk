<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryEduLlmModelResponseResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryEduLlmModelResponseResponseBody\result\modelResult\usage;
use AlibabaCloud\Tea\Model;

class modelResult extends Model
{
    /**
     * @example ```json\n{\n  \"题目1\": {\n    \"左侧括号内学生答案\": \"√\",\n    \"右侧括号内学生答案\": \"\"\n  },\n  \"题目2\": {\n    \"左侧括号内学生答案\": \"√\",\n    \"右侧括号内学生答案\": \"\"\n  },\n  \"题目3\": {\n    \"左侧括号内学生答案\": \"√\",\n    \"右侧括号内学生答案\": \"\"\n  },\n  \"题目4\": {\n    \"左侧括号内学生答案\": \"√\",\n    \"右侧括号内学生答案\": \"√\"\n  },\n  \"题目5\": {\n    \"左侧括号内学生答案\": \"\",\n    \"右侧括号内学生答案\": \"√\"\n  },\n  \"题目6\": {\n    \"左侧括号内学生答案\": \"√\",\n    \"右侧括号内学生答案\": \"\"\n  }\n}\n```
     *
     * @var string
     */
    public $content;

    /**
     * @var usage
     */
    public $usage;
    protected $_name = [
        'content' => 'content',
        'usage' => 'usage',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->usage) {
            $res['usage'] = null !== $this->usage ? $this->usage->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return modelResult
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['usage'])) {
            $model->usage = usage::fromMap($map['usage']);
        }

        return $model;
    }
}
