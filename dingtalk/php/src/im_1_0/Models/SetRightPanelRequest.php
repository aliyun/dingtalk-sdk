<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\SetRightPanelRequest\webWndParams;
use AlibabaCloud\Tea\Model;

class SetRightPanelRequest extends Model
{
    /**
     * @example ciddjxhgdDXSAAXXXXX
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @var bool
     */
    public $rightPanelClosePermitted;

    /**
     * @example 1
     *
     * @var int
     */
    public $rightPanelOpenStatus;

    /**
     * @example 侧边栏标题
     *
     * @var string
     */
    public $title;

    /**
     * @var webWndParams
     */
    public $webWndParams;

    /**
     * @example 500
     *
     * @var int
     */
    public $width;
    protected $_name = [
        'openConversationId'       => 'openConversationId',
        'rightPanelClosePermitted' => 'rightPanelClosePermitted',
        'rightPanelOpenStatus'     => 'rightPanelOpenStatus',
        'title'                    => 'title',
        'webWndParams'             => 'webWndParams',
        'width'                    => 'width',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->rightPanelClosePermitted) {
            $res['rightPanelClosePermitted'] = $this->rightPanelClosePermitted;
        }
        if (null !== $this->rightPanelOpenStatus) {
            $res['rightPanelOpenStatus'] = $this->rightPanelOpenStatus;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->webWndParams) {
            $res['webWndParams'] = null !== $this->webWndParams ? $this->webWndParams->toMap() : null;
        }
        if (null !== $this->width) {
            $res['width'] = $this->width;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SetRightPanelRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['rightPanelClosePermitted'])) {
            $model->rightPanelClosePermitted = $map['rightPanelClosePermitted'];
        }
        if (isset($map['rightPanelOpenStatus'])) {
            $model->rightPanelOpenStatus = $map['rightPanelOpenStatus'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['webWndParams'])) {
            $model->webWndParams = webWndParams::fromMap($map['webWndParams']);
        }
        if (isset($map['width'])) {
            $model->width = $map['width'];
        }

        return $model;
    }
}
