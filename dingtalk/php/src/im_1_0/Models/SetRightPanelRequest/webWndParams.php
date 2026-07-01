<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\SetRightPanelRequest;

use AlibabaCloud\Tea\Model;

class webWndParams extends Model
{
    /**
     * @example xxxxx
     *
     * @var string
     */
    public $closeTipContent;

    /**
     * @description This parameter is required.
     *
     * @example https://www.dingtalk.com/
     *
     * @var string
     */
    public $targetURL;
    protected $_name = [
        'closeTipContent' => 'closeTipContent',
        'targetURL' => 'targetURL',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->closeTipContent) {
            $res['closeTipContent'] = $this->closeTipContent;
        }
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
        if (isset($map['closeTipContent'])) {
            $model->closeTipContent = $map['closeTipContent'];
        }
        if (isset($map['targetURL'])) {
            $model->targetURL = $map['targetURL'];
        }

        return $model;
    }
}
