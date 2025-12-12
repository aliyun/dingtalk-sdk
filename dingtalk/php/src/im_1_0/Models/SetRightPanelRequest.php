<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\SetRightPanelRequest\webWndParams;
use AlibabaCloud\Tea\Model;

class SetRightPanelRequest extends Model
{
    /**
     * @var bool
     */
    public $forceExpand;

    /**
     * @var bool
     */
    public $isQtWnd;

    /**
     * @description This parameter is required.
     *
     * @example ciddjxhgdDXSAAXXXXX
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @description This parameter is required.
     *
     * @var bool
     */
    public $rightPanelClosePermitted;

    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var int
     */
    public $rightPanelOpenStatus;

    /**
     * @description This parameter is required.
     *
     * @example 侧边栏标题
     *
     * @var string
     */
    public $title;

    /**
     * @description This parameter is required.
     *
     * @var webWndParams
     */
    public $webWndParams;

    /**
     * @description This parameter is required.
     *
     * @example 500
     *
     * @var int
     */
    public $width;
    protected $_name = [
        'forceExpand' => 'forceExpand',
        'isQtWnd' => 'isQtWnd',
        'openConversationId' => 'openConversationId',
        'rightPanelClosePermitted' => 'rightPanelClosePermitted',
        'rightPanelOpenStatus' => 'rightPanelOpenStatus',
        'title' => 'title',
        'webWndParams' => 'webWndParams',
        'width' => 'width',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->forceExpand) {
            $res['forceExpand'] = $this->forceExpand;
        }
        if (null !== $this->isQtWnd) {
            $res['isQtWnd'] = $this->isQtWnd;
        }
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
        if (isset($map['forceExpand'])) {
            $model->forceExpand = $map['forceExpand'];
        }
        if (isset($map['isQtWnd'])) {
            $model->isQtWnd = $map['isQtWnd'];
        }
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
