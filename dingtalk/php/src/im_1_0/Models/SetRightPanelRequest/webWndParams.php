<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\SetRightPanelRequest;

use AlibabaCloud\Tea\Model;

class webWndParams extends Model
{
    /**
     * @description 侧边栏URL
     *
     * @var string
     */
    public $targetURL;
    protected $_name = [
        'targetURL' => 'targetURL',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->targetURL) {
            $res['targetURL'] = $this->targetURL;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return webWndParams
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['targetURL'])) {
            $model->targetURL = $map['targetURL'];
        }

        return $model;
    }
}
