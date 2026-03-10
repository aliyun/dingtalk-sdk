<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\RobotReplyEmotionRequest;

use AlibabaCloud\Tea\Model;

class textEmotion extends Model
{
    /**
     * @example im_bg_1
     *
     * @var string
     */
    public $backgroundId;

    /**
     * @example 12345
     *
     * @var string
     */
    public $emotionId;

    /**
     * @example OK
     *
     * @var string
     */
    public $emotionName;

    /**
     * @example OK
     *
     * @var string
     */
    public $text;
    protected $_name = [
        'backgroundId' => 'backgroundId',
        'emotionId' => 'emotionId',
        'emotionName' => 'emotionName',
        'text' => 'text',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->backgroundId) {
            $res['backgroundId'] = $this->backgroundId;
        }
        if (null !== $this->emotionId) {
            $res['emotionId'] = $this->emotionId;
        }
        if (null !== $this->emotionName) {
            $res['emotionName'] = $this->emotionName;
        }
        if (null !== $this->text) {
            $res['text'] = $this->text;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return textEmotion
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['backgroundId'])) {
            $model->backgroundId = $map['backgroundId'];
        }
        if (isset($map['emotionId'])) {
            $model->emotionId = $map['emotionId'];
        }
        if (isset($map['emotionName'])) {
            $model->emotionName = $map['emotionName'];
        }
        if (isset($map['text'])) {
            $model->text = $map['text'];
        }

        return $model;
    }
}
