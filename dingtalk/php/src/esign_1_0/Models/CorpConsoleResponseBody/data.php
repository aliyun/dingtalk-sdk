<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models\CorpConsoleResponseBody;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @var int
     */
    public $orgConsoleUrl;
    protected $_name = [
        'orgConsoleUrl' => 'orgConsoleUrl',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->orgConsoleUrl) {
            $res['orgConsoleUrl'] = $this->orgConsoleUrl;
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
        if (isset($map['orgConsoleUrl'])) {
            $model->orgConsoleUrl = $map['orgConsoleUrl'];
        }

        return $model;
    }
}
