<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models;

use AlibabaCloud\Tea\Model;

class GetCorpConsoleResponseBody extends Model
{
    /**
     * @var string
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
     * @return GetCorpConsoleResponseBody
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
