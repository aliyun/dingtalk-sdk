<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetNavigationCatalogResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetNavigationCatalogResponseBody\result\navCatalog;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var string
     */
    public $bizTraceId;

    /**
     * @var string
     */
    public $module;

    /**
     * @var navCatalog[]
     */
    public $navCatalog;
    protected $_name = [
        'bizTraceId' => 'bizTraceId',
        'module'     => 'module',
        'navCatalog' => 'navCatalog',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizTraceId) {
            $res['bizTraceId'] = $this->bizTraceId;
        }
        if (null !== $this->module) {
            $res['module'] = $this->module;
        }
        if (null !== $this->navCatalog) {
            $res['navCatalog'] = [];
            if (null !== $this->navCatalog && \is_array($this->navCatalog)) {
                $n = 0;
                foreach ($this->navCatalog as $item) {
                    $res['navCatalog'][$n++] = null !== $item ? $item->toMap() : $item;
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
        if (isset($map['bizTraceId'])) {
            $model->bizTraceId = $map['bizTraceId'];
        }
        if (isset($map['module'])) {
            $model->module = $map['module'];
        }
        if (isset($map['navCatalog'])) {
            if (!empty($map['navCatalog'])) {
                $model->navCatalog = [];
                $n                 = 0;
                foreach ($map['navCatalog'] as $item) {
                    $model->navCatalog[$n++] = null !== $item ? navCatalog::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
