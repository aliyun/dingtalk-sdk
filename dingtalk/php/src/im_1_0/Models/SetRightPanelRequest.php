<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\SetRightPanelRequest\webWndParams;
use AlibabaCloud\Tea\Model;

class SetRightPanelRequest extends Model
{
    /**
     * @description 场景群的openConversationId
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @description 是否允许群成员关闭侧边栏 true-允许 false-不允许
     *
     * @var bool
     */
    public $rightPanelClosePermitted;

    /**
     * @description 侧边栏打开状态 1-开启 0-关闭
     *
     * @var int
     */
    public $rightPanelOpenStatus;

    /**
     * @description 标题栏文案
     *
     * @var string
     */
    public $title;

    /**
     * @description 网页侧边栏属性配置
     *
     * @var webWndParams
     */
    public $webWndParams;

    /**
     * @description 侧边栏
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
