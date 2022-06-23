<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetCheckInSchemaTemplateResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetCheckInSchemaTemplateResponseBody\result\waterMarkTemplateModels;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 业务码。
     *
     * @var string
     */
    public $bizCode;

    /**
     * @description 是否可以操作模板。
     *
     * @var bool
     */
    public $canModifyAndAddTemplate;

    /**
     * @description 是否群管理员。
     *
     * @var bool
     */
    public $conversationAdmin;

    /**
     * @description 自定义模板的最大数量。
     *
     * @var int
     */
    public $customTemplateMaxSize;

    /**
     * @description 群会话ID。
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @description 是否展示统计入口。
     *
     * @var bool
     */
    public $showStat;

    /**
     * @description 是否开启水印模板降级。
     *
     * @var bool
     */
    public $templateDegrade;

    /**
     * @description 模板列表。
     *
     * @var waterMarkTemplateModels[]
     */
    public $waterMarkTemplateModels;
    protected $_name = [
        'bizCode'                 => 'bizCode',
        'canModifyAndAddTemplate' => 'canModifyAndAddTemplate',
        'conversationAdmin'       => 'conversationAdmin',
        'customTemplateMaxSize'   => 'customTemplateMaxSize',
        'openConversationId'      => 'openConversationId',
        'showStat'                => 'showStat',
        'templateDegrade'         => 'templateDegrade',
        'waterMarkTemplateModels' => 'waterMarkTemplateModels',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizCode) {
            $res['bizCode'] = $this->bizCode;
        }
        if (null !== $this->canModifyAndAddTemplate) {
            $res['canModifyAndAddTemplate'] = $this->canModifyAndAddTemplate;
        }
        if (null !== $this->conversationAdmin) {
            $res['conversationAdmin'] = $this->conversationAdmin;
        }
        if (null !== $this->customTemplateMaxSize) {
            $res['customTemplateMaxSize'] = $this->customTemplateMaxSize;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->showStat) {
            $res['showStat'] = $this->showStat;
        }
        if (null !== $this->templateDegrade) {
            $res['templateDegrade'] = $this->templateDegrade;
        }
        if (null !== $this->waterMarkTemplateModels) {
            $res['waterMarkTemplateModels'] = [];
            if (null !== $this->waterMarkTemplateModels && \is_array($this->waterMarkTemplateModels)) {
                $n = 0;
                foreach ($this->waterMarkTemplateModels as $item) {
                    $res['waterMarkTemplateModels'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizCode'])) {
            $model->bizCode = $map['bizCode'];
        }
        if (isset($map['canModifyAndAddTemplate'])) {
            $model->canModifyAndAddTemplate = $map['canModifyAndAddTemplate'];
        }
        if (isset($map['conversationAdmin'])) {
            $model->conversationAdmin = $map['conversationAdmin'];
        }
        if (isset($map['customTemplateMaxSize'])) {
            $model->customTemplateMaxSize = $map['customTemplateMaxSize'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['showStat'])) {
            $model->showStat = $map['showStat'];
        }
        if (isset($map['templateDegrade'])) {
            $model->templateDegrade = $map['templateDegrade'];
        }
        if (isset($map['waterMarkTemplateModels'])) {
            if (!empty($map['waterMarkTemplateModels'])) {
                $model->waterMarkTemplateModels = [];
                $n                              = 0;
                foreach ($map['waterMarkTemplateModels'] as $item) {
                    $model->waterMarkTemplateModels[$n++] = null !== $item ? waterMarkTemplateModels::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
