<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryMinutesTextResponseBody\paragraphList;

use AlibabaCloud\Tea\Model;

class speakerDisplay extends Model
{
    /**
     * @var string
     */
    public $avatarUrl;

    /**
     * @var string
     */
    public $nickName;
    protected $_name = [
        'avatarUrl' => 'avatarUrl',
        'nickName' => 'nickName',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->avatarUrl) {
            $res['avatarUrl'] = $this->avatarUrl;
        }
        if (null !== $this->nickName) {
            $res['nickName'] = $this->nickName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return speakerDisplay
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['avatarUrl'])) {
            $model->avatarUrl = $map['avatarUrl'];
        }
        if (isset($map['nickName'])) {
            $model->nickName = $map['nickName'];
        }

        return $model;
    }
}
