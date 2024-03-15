<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdpaas_1_0\Models;

use AlibabaCloud\Tea\Model;

class InstallCoolAppOrderToGroupRequest extends Model
{
    /**
     * @example cidxxx
     *
     * @var string
     */
    public $conversationId;

    /**
     * @var int[]
     */
    public $sortedPluginIdList;

    /**
     * @example template-id-xxx
     *
     * @var string
     */
    public $templateId;

    /**
     * @var int[]
     */
    public $unsortedPluginIdList;
    protected $_name = [
        'conversationId'       => 'conversationId',
        'sortedPluginIdList'   => 'sortedPluginIdList',
        'templateId'           => 'templateId',
        'unsortedPluginIdList' => 'unsortedPluginIdList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->conversationId) {
            $res['conversationId'] = $this->conversationId;
        }
        if (null !== $this->sortedPluginIdList) {
            $res['sortedPluginIdList'] = $this->sortedPluginIdList;
        }
        if (null !== $this->templateId) {
            $res['templateId'] = $this->templateId;
        }
        if (null !== $this->unsortedPluginIdList) {
            $res['unsortedPluginIdList'] = $this->unsortedPluginIdList;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return InstallCoolAppOrderToGroupRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['conversationId'])) {
            $model->conversationId = $map['conversationId'];
        }
        if (isset($map['sortedPluginIdList'])) {
            if (!empty($map['sortedPluginIdList'])) {
                $model->sortedPluginIdList = $map['sortedPluginIdList'];
            }
        }
        if (isset($map['templateId'])) {
            $model->templateId = $map['templateId'];
        }
        if (isset($map['unsortedPluginIdList'])) {
            if (!empty($map['unsortedPluginIdList'])) {
                $model->unsortedPluginIdList = $map['unsortedPluginIdList'];
            }
        }

        return $model;
    }
}
