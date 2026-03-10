<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CallMultimodalModelResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CallMultimodalModelResponseBody\result\usage;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example ```json\n{\n  \"题目1\": {\n    \"左侧括号内学生答案\": \"√\",\n    \"右侧括号内学生答案\": \"\"\n  },\n  \"题目2\": {\n    \"左侧括号内学生答案\": \"√\",\n    \"右侧括号内学生答案\": \"\"\n  }\n}\n```
     *
     * @var string
     */
    public $content;

    /**
     * @example requestxxxxxxx
     *
     * @var string
     */
    public $reqId;

    /**
     * @var usage
     */
    public $usage;
    protected $_name = [
        'content' => 'content',
        'reqId' => 'reqId',
        'usage' => 'usage',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->reqId) {
            $res['reqId'] = $this->reqId;
        }
        if (null !== $this->usage) {
            $res['usage'] = null !== $this->usage ? $this->usage->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['reqId'])) {
            $model->reqId = $map['reqId'];
        }
        if (isset($map['usage'])) {
            $model->usage = usage::fromMap($map['usage']);
        }

        return $model;
    }
}
