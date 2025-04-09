<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models\AssistantMeResponseResponseBody\output;

use AlibabaCloud\Tea\Model;

class content extends Model
{
    /**
     * @var mixed[]
     */
    public $annotations;

    /**
     * @var string
     */
    public $text;

    /**
     * @var string
     */
    public $type;
    protected $_name = [
        'annotations' => 'annotations',
        'text' => 'text',
        'type' => 'type',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->annotations) {
            $res['annotations'] = $this->annotations;
        }
        if (null !== $this->text) {
            $res['text'] = $this->text;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return content
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['annotations'])) {
            if (!empty($map['annotations'])) {
                $model->annotations = $map['annotations'];
            }
        }
        if (isset($map['text'])) {
            $model->text = $map['text'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
